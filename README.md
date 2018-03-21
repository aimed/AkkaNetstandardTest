The following configurations have been tests.
The ultimate goal is to compile the project in such a way, that it can be run by mono and dotnet.

| TargetFramework | build | dotnet run x | mono x | Notes |
| --------------- | ----- | ------------ | ------ | ----- |
| netcoreapp | dotnet publish | OK  | ERR1   | In publish folder |
| netstandard | dotnet publish | ERR2 | ERR3 | In publish folder |
| netstandard | mono | ERR4 | ERR5 | |
| netcoreapp | mono | OK | ERR6 | |

ERR1:
```
System.TypeLoadException: Could not resolve type with token 0100000e (from typeref, class/assembly System.Threading.Tasks.Task, System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)
[ERROR] FATAL UNHANDLED EXCEPTION: System.TypeLoadException: Could not resolve type with token 0100000e (from typeref, class/assembly System.Threading.Tasks.Task, System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)
```

-----

ERR2:
```
A fatal error was encountered. The library 'libhostpolicy.dylib' required to execute the application was not found in '/Users/max/git/tst/bin/Debug/netstandard2.0/publish/'.
```

ERR3:
```
System.MissingMethodException: Method 'Akka.Actor.Props.Create' not found.
[ERROR] FATAL UNHANDLED EXCEPTION: System.MissingMethodException: Method 'Akka.Actor.Props.Create' not found.
```

-----


ERR4:
```
A fatal error was encountered. The library 'libhostpolicy.dylib' required to execute the application was not found in '/Users/max/git/tst/bin/Debug/netstandard2.0/'.
```

ERR5: 
```
Unhandled Exception:
System.IO.FileNotFoundException: Could not load file or assembly 'Akka, Version=1.3.5.0, Culture=neutral, PublicKeyToken=null' or one of its dependencies.
File name: 'Akka, Version=1.3.5.0, Culture=neutral, PublicKeyToken=null'
[ERROR] FATAL UNHANDLED EXCEPTION: System.IO.FileNotFoundException: Could not load file or assembly 'Akka, Version=1.3.5.0, Culture=neutral, PublicKeyToken=null' or one of its dependencies.
File name: 'Akka, Version=1.3.5.0, Culture=neutral, PublicKeyToken=null'
```

-----

ERR6:
```
Unhandled Exception:
System.TypeLoadException: Could not resolve type with token 0100000e (from typeref, class/assembly System.Threading.Tasks.Task, System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)
[ERROR] FATAL UNHANDLED EXCEPTION: System.TypeLoadException: Could not resolve type with token 0100000e (from typeref, class/assembly System.Threading.Tasks.Task, System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)
```