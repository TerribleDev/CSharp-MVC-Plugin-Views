## What is this?

This is a simple MVC application to show the Power of custom `Display Templates`. This sample as a ViewModel that contains a list of 'ITile objects'. Ultimatly these are tiles that end up in a bootstrap grid. We have a controller which creates 2 different types of tiles, and using the `DisplayFor()` we end up with **very** different behaviors based on the tile's `Type`

One tile is a simple text tile to show text on the DOM, the other tile is an image tile that displays a responsive image. using this type of Architecture you could make an upload tile, or additional behaviors 

![Capture](capture.png)