# The Little F#er (The Little FSharper)

This repository is a collection of [.NET Interactive](https://github.com/dotnet/interactive) notebooks that serve as [F#](https://fsharp.org/) implementations and annotations of the various types, functions, and questions and their responses found in the wonderful book [*The Little MLer* by Matthias Felleisen and Daniel P. Friedman](https://mitpress.mit.edu/9780262561143/the-little-mler/).

Just click on and browse the notebooks for the various chapters to get a taste. GitHub renders the F# notebooks in any browser, so you can view the notebooks without installing any code. You can even press `.` while viewing this repository, and GitHub will open up a web-based Visual Studio Code instance, so you can view the code that way as well. Try it!

Note: This repository is in progress of converting the old F# script files to notebooks and finishing all the chapters.

## Introduction

The book's code is closest to Standard ML (SML), as explained on page xiii, and there is some guidance on using Objective Caml (OCaml) with the book, as explained on pages xv - xvi. While both SML and OCaml are wonderful languages, these days, F# has some features that makes it a wonderful tool to go through *The Little MLer* with.

1. F# is heavily inspired by SML and OCaml and originally was basically a port of OCaml to .NET. These days, it is its own language though.
2. F# is easier to install on any operating system. F# is fully cross-platform and is not Windows only, and it runs equally well on all three OSes of Windows, macOS, and Linux.
3. F# is more widely supported. Since F# is a .NET language, it benefits from the huge amount of effort going into .NET, both for the runtime, the framework, and libraries developed in .NET languages.
4. F# has a wider variety of high quality development environments.
    * Windows: [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
    * macOS: [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
    * Windows, macOS, Linux:
        * [Visual Studio Code](https://code.visualstudio.com/) with either the [.NET Interactive Notebooks extension (as used in this repository)](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode) or the [Ionide extension (more of an IDE experience)](https://marketplace.visualstudio.com/items?itemName=Ionide.Ionide-fsharp)
        * [JetBrains Rider with the F# plugin](https://www.jetbrains.com/help/rider/F_Sharp.html)
5. Notebooks are the best way to provide executable code that follows a book or a topic, and F#'s notebooks are easy to use on any OS. This could be the primary reason for using F#.
6. F# is a cleaner language. This may be subjective, but there is some objective truth to it. SML and OCaml have some features that F# does't have, and vice versa, but overall, F# has a cleaner and more consistent and modern syntax.

## Goals

Hopefully this repository helps in two ways:

* Allows you to enjoy the ideas found in *The Little MLer*

* Gets you familiar with idiomatic F# code and also F# notebooks

And hopefully you'll go on to write and use F# even more!

## Installation process to run the notebooks

1. [Install .NET 6 or higher](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/install). This installs F#, and you can test that after instllation .NET with `dotnet fsi` to enter into [F# Interactive (FSI)](https://docs.microsoft.com/en-us/dotnet/fsharp/tools/fsharp-interactive/).

2. [Install Visual Studio Code (VS Code)](https://code.visualstudio.com/)

3. [Install the .NET Interactive Notebooks extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)

That's it! Just three installers that should take just a few minutes, and you can view, edit, and run the notebooks in this repository without issue.
