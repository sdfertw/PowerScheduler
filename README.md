## What is this project

You find this project most useful if, for whatever reason (e.g.: company policy), your power settings are reset on a regular basis and you want to keep them on some other settings.

A good reason would be if you wanted to keep your laptop fan down.

Another example is if you want to code on the rooftop of your office and want your laptop to go for a few hours on batteries.

Or if you happen to be on meetings all day long and you want to get hours of battery life.

## How to use it

* Change the settings of the Balanced power profile.
* Compile the project.
* Install the service "installutil powerscheduler.exe"
* You need to start it with "net start powerscheduler" or restart computer (I dunno why Start/Stop is disabled in the Services)

## What power settings you want to use to silence the fan, code on the roof, enjoy long meetings...

Control panel -> Power options -> Balanced -> Change plan settings -> Change advanced power settings -> Processor power management -> Maximum processor state

Change "Plugged in" to like 80% (maybe 90% also does the job) to silence your fan
Change "On battery" to for example to 50% to double your roof life. Needless to say, your compile times will go up a bit :)
Change "On battery" to 25% or lower if you plan long meetings with your laptop :)

## How does it work
The PowerScheduler windows service changes the power plan to *Balanced* every 60 seconds.