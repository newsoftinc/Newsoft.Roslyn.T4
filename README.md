
Newsoft.Roslyn.T4
===================
Is a set of ttinclude files to use in your project to analyze a solution using the roslyn compiler and provide metadata to generate custom content, class, test and documentation files from Text Template (.tt) files.

----------
Files
-------------

Class     | Description
-------- | ---
NewsoftRoslyn.Core.ttinclude | Main reference file. Include other text templates and provide a signle point
NewsoftRoslyn.Dependencies.ttinclude    | References all the required DLL to use Roslyn in your templates
NewsoftRoslyn.Helpers.ttinclude    | Provide some usefull helpers to work with Roslyn objects
NewsoftRoslyn.VsProject.ttinclude      | A wrapper of Microsoft.Analysis.Project
NewsoftRoslyn.VsSolution.ttinclude       |  A wrapper of Microsoft.Analysis.Solution
Sample.tt       |  A text template file with examples


----------
Getting started
-------------
----------
> - Add all of the ttinclude files to your project
> - Add a project reference to the nuget package Microsoft.CodeAnalysis 
> **Nuget console:**
 Install-Package Microsoft.CodeAnalysis

