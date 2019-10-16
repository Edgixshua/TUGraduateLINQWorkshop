# TUGraduateLINQWorkshop

LINQ workshop for new graduate intake

## How will this work

The workshop is a test driven development project, with existing unit tests which fail

The aim of this workshop is to make the tests pass using LINQ operators

Please disable resharper if you have it enabled (it helps out too much to learn!)

There are 4 levels of difficulty - Basic (Implemented) - Basic - Intermediate - Advanced.
It is suggested that you start with Basic, and if you're struggling, take a look at how they are implemented with loops in the Implemented section. After you have finished Basic move on to intermediate, then advanced.

We also have some stress LINQ tests if you're interested in seeing how LINQ performs when working with hundreds of thousands of rows of data.

## Getting started

If you need any help with these steps, ask one of the demonstrators or your fellow associates

- Clone the code (`git clone https://github.com/Edgixshua/TUGraduateLINQWorkshop.git`) into your source folder
- Create a branch and check it out (
    `git branch yourInitials/yourBranchName` and then `git checkout yourIntials/yourBranchName`
    or shorthand `git checkout -b yourIntials/yourBranchName`)
- Open the GraduateLINQWorkShop.sln in Visual Studio
- Build the solution and check that you can run the tests, most of them should fail, don't worry about that for now
- Work on implementing the methods one by one, making sure all the tests pass for that method
- Commit your changes to your branch as you go (suggested method by method)
- Ask the demonstrators questions to solidify your understanding!

## Permissions errors accessing GitHub

If you're struggling to access github to clone the code please ask one of the demonstrators for instructions on how to fix this

## Help

- You may find looking through the LINQ documentation on <https://docs.microsoft.com/en-us/dotnet/api/system.linq?view=netframework-4.8> (Enumerable -> Methods) useful
