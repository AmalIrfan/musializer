# Musializer

## Quick Start

```console
$ ./build.sh
$ ./build/musualizer <song.ogg>
```

## Hot Reloading

```console
$ export HOTRELOAD=1
$ export LD_LIBRARY_PATH="./build/:$LD_LIBRARY_PATH"
$ ./build.sh
$ ./build/musualizer <song.ogg>
```

Keep the app running. Rebuild with `./build.sh`. Hot reload by focusing on the window of the app and pressing <kbd>r</kbd>.