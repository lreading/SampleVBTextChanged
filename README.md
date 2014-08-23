SampleVBTextChanged
===================

A sample VB project to demonstrate how the TextChanged event handler can be leveraged to update a `Label` from a `TextBox`.


This was in response to [this Stack Overflow question](http://stackoverflow.com/questions/25436548/how-to-dynamically-update-label-with-textbox-as-input-changes/).



The Problem:
-
Using VB.Net in a Winform project, update a `Label` as a user types in a `TextBox`.

The Solution:
-
Utilize the TextChanged event handler and assign the `Text` property of the given `Label` to the `Text` property of the given `TextBox`.

Limitations:
-
This program makes no attempt to format the text for the label, or store the text values  It's sole purpose is to take a user's input and display it in a `label` form element as the user is typing.
