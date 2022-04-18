# ScreenController
Screen Controller is an elegant way of dealing with many Screens in Unity3D.
HOW TO USE THIS METHOD?

1. Copy ScreenController and screen scripts.
2. Import them into your project.
3. Create you screens and put them as a child of a gameobject.
4. Now add ScreenController to that gameobject.
5. Its time to create a screen, inherit screen class into your customise screen and assign appropriate screen ID to them.
6. This Screen ID is going to be an enum which is declare in ScreenController extend this end accourding to you screens.
7. Each screens which inherit from screen class can override function like Show() and Hide().
8. This function gonna act as an entry and exit points in the screens.
9. And if you want to add some customize animation to the screens just like in the demo then coustomize the ScreenSlideAnimation class accordingly.
10. There is a boolen variable inside ScreenSlideAnimation class called allowAnimation if there is a need to avoid animation on some classes. 
Please set it false from inspector.

Why you should use this method?
1. Simple and easy to implementation.
2. Can able to goto any screen without worrying about unable and disable any gameobject.
3. Easy to scale without breaking exiting code.
4. Can traverse to previous screens with back function.
5. Ever screen will get informed when any screen is enable or disable.

https://youtube.com/shorts/JQBn3HIYiwY
