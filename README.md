# Minutes to Read plugin for Verint Community

![Build Status](https://ardourdigital.visualstudio.com/_apis/public/build/definitions/8b5ba8e6-4059-46da-8ac1-e2bcf922c889/6/badge)

A lot of sites now show a "X minutes read" message on content, to help users understand how long the piece of content is.

Verint Community (aka Telligent Community) doesn't support this out the box, so this plugin does gives you the ability to add it to your community.

The estimated time to read is calculated by assuming the user [can read 200 words per minute](https://www.google.com/search?q=read+words+per+minute&oq=read+words+per+minute).

This plugin provides a widget you can use straight away and an extension you can use to develop your own widgets.

## Supported Versions
This plugin should work with the following versions of Telligent Community
- Telligent Community 9.x
- Telligent Community 10.x
- Verint Community 11.x

## Installation

You can install the plugin by [downloading the latest version](https://github.com/ArdourDigital/ArdourDigital.TelligentCommunity.MinutesToRead/releases/latest) and adding it to your sites `bin` folder, or if you are using Visual Studio you can use nuget:

```
Install-Package ArdourDigital.TelligentCommunity.MinutesToRead
```

The plugin can then be enabled by logging in as an administrator, and going to `Administration` > `Extensions` and finding `Ardour Digital - Minutes to Read`. 

## Usage

### Minutes To Read Widget
The widget that is supplied by this plugin is a basic widget that displays the estimated number of minutes it would take to read the current content.

If the widget can't identify the current content/get the body content the widget will be hidden.

The text displayed can be edited in the Resources section of the widget, there are two versions of text used. If the estimated time to read is only 1 minute then the widget will say `1 minute read.`, if it is more then the widget will say `{0} minutes read.` where `{0}` is replaced with the estimated number of minutes.

The widget uses standard Telligent styles, you may want to add your own styling based on where you are using the widget. This can be done by targeting the `minutes-to-read` class.

### Minutes to Read Extension
If you would like to get the estimated number of minutes for use in another widget you can use the extension provided.

```
#set($content = $core_v2_content.Current)
#set($minutesToRead = $ardour_v1_minutesToRead.GetNumberOfMinutesToRead($content.ContentId, $content.ContentTypeId))
```

You can then use the `$minutesToRead` value as necessary.