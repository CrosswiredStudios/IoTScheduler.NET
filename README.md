# IoTScheduler.NET
Task Scheduling library for projects targeting Windows IoT (UWP)

The goal of IoTScheduler is to provide a useful scheduling system for projects using Windows IoT/RT/Core

It has no external dependencies and allows a developer to trigger function calls at specific times. There are 3 types of Tasks you can create:

* Single
* Daily
* Custom

As the names imply, these tasks allow you to set up single time use and reccuring events that fire at a given time in the day.

The library includes no persistence. You will want to wrap the scheduler in a class that builds a list of tasks from a file or databse.
