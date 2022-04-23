# NewsReportAPIService: Setup


## Clone the Project Files

The files are in the folowing github repository: 
[NewsReportAPIService](https://github.com/10570708/NewsReportAPIService.git)
(https://github.com/10570708/NewsReportAPIService.git)

Clone the files locally using either 

### Command Line

- Open GitBash and create the local directory for your project
- Go to that directory
- Type git clone in the terminal, paste the URL for the Application, and press �enter� to create your local clone.

![Git Clone](images/gitclone.jpg)



##**or**

### Directly in Visual Studio 2022 
- Open Project
- Select 'Clone a repository' 

![Visual Studio 1](images/vstudio1.jpg)

- Enter the Github URL 
- Enter the path to your local directory
- Click Clone


![Git Clone](images/gitclone1.jpg)


## Open the Solution in Visual Studio 2022

- Load the solution
- Make sure in the Package Manager Console that it is set as the 'Default Project'
- In the Package Manager Console run the command 

    `Update-Database`



**The package dependencies shuld be managed automatically, but if not, use NuGet Package Manager to install them. The list of required NuGet Packages is: **

![NuGet](images/NuGet.jpg)


## Run the Application 

- The application can now be run, however there are configuration settings to consider before doing so. 
 
	[Configuration setting & pre-requisites](config.md)






[Back to Index](index.md)


