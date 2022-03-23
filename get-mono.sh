function checkresult
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

if [ -z "$1" ]
then
    echo No local mono directory supplied. Cloning mono from Github. This may take a while...
    echo You can provide a local mono checkout using: $0 \<path-to-mono-git-repository\>
    MONO_GIT=https://github.com/mono/mono.git
else
    MONO_GIT=$1/.git
fi

echo =====CHECKING OUT MONO FROM $MONO_GIT=====
if [ -z $USE_LATEST_MONO ]
then
    MONO_GIT_CHECKOUT=3b5c655c055910e9e98b6c543f516f143448d636
    echo =====USING SUPPORTED REVISION OF MONO: $MONO_GIT_CHECKOUT=====
else
    echo =====USING LATEST REVISION OF MONO! THIS MAY NOT BE STABLE!=====
    MONO_GIT_CHECKOUT=origin/mono-2-8
fi

ROOT_DIR=$(basename $0)
pushd $(dirname $0)/jni

echo
echo =====CHECKING OUT MONO=====
if [ -d mono ]
then
    echo =====UPDATING EXISTING MONO CHECKOUT=====
    echo =====If you get errors, you may want to delete mono and hostbuild to force a clean build=====
    pushd mono
    MONO_SKIP_PATCH=true
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./mono'
    pushd ../hostbuild/mono
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./hostbuild/mono'
else
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    popd

    rm -rf ../hostbuild
    mkdir -p ../hostbuild
    pushd ../hostbuild
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    popd
    popd
fi

echo
echo =====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD=====
sleep 2
export CC=$(which gcc-4.0)
export CXX=$(which g++-4.0)
pushd ../hostbuild/mono/eglib
if [ ! -f configure ]
then
    ./autogen.sh --prefix=$ROOT_DIR/hostbuild/install
fi
popd

mkdir -p ../hostbuild/install
pushd ../hostbuild/install
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd ../hostbuild/mono
UNAME=$(uname -a | grep Darwin | grep x86_64)
if [ ! -z "$UNAME" ]
then
    echo Using gcc-4.0 on Darwin x86_64!
    export CC=gcc-4.0
fi
if [ ! -f configure ]
then
    ./autogen.sh --with-glib=embedded --with-moonlight=no --prefix=$INSTALL_PREFIX
fi
make && make install
popd

if [ ! -f mono.patch ]
then
    echo =====NO LOCAL MONO PATCH FOUND=====
    MONO_SKIP_PATCH=true
fi

if [ -z $MONO_SKIP_PATCH ]
then
    pushd mono
    echo
    echo =====APPLYING ANDROID PATCHES FOR ARM BUILD=====
    patch -p0 -i ../mono.patch
    popd
fi

echo "=====Done! Don't forget Rebuild the ARM build using the Android NDK now!====="
