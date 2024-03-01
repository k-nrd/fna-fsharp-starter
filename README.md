# What is this?

[FNA](https://github.com/FNA-XNA/FNA) is an awesome project that reimplements the original Microsoft.XNA libraries. It is cross-platform by default and has been used both to build and to port many great games.

To start a new project with FNA you do need to go through a [non-trivial setup](https://github.com/FNA-XNA/FNA/wiki/1:-Setting-Up-FNA), which requires cloning FNA and referencing it in your game project, downloading native libs and copying them over into your assembly output after building your project.

Even though the setup ceremony is not devilishly hard to execute or anything like that, I attempted to mitigate the issue of having to do stuff manually through my (still newbie level) MSBuild-foo (because I'm a lazy bum).

`Game.fsproj` contains some basic MSBuild tasks that automate the setup process. Hope it helps!

If you have nice MSBuild chops and want to improve on this, my TODO list basically is this:

- [ ] Create platform-specific tasks where we copy the right libs for the architecture
