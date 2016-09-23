# IoTScheduler.NET
Task Scheduling library for projects targeting Windows IoT (UWP)

The goal of IoTScheduler is to provide a useful scheduling system for projects using Windows IoT/RT/Core

It has no external dependencies and allows a developer to trigger function calls at specific times. There are 3 types of Tasks you can create:

* Single
* Daily
* Custom

As the names imply, these tasks allow you to set up single time use and reccuring events that fire at a given time in the day.

The library includes no persistence. You will want to wrap the scheduler in a class that builds a list of tasks from a file or databse.


Protip:

If you would like to debug your embedded apps locally there is a way! Just very well hidden documentation.
Download the Windows ADK (https://developer.microsoft.com/en-us/windows/hardware/windows-assessment-deployment-kit) and make sure to include the Windows Imaging and Configuration Designer.
Instructions for enabling embedded mode can be found under Debugging Background Application at https://developer.microsoft.com/en-us/windows/iot/docs/embeddedmode. Good Luck!