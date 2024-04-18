# Mobile app for Bulgarian Birds for a uni assignment

## **Summary**
I made this app as a uni project for my mobile development classes. It's about reading facts about Tit birds and Vultures in Bulgaria. Initially it was a single-page app with a much simpler design, but I decided to extend it as a final project for the subject. There were several hurdles to overcome:

1. The xaml language. Dealing with the visual heirarchy and making the design render properly on different screen sizes really was a challenge. However, I much enjoyed the process of learning the new technology and being able to express myself better through the UI.
2. The Shell structure. One of its benefits is that it loads each page as it's opened, and not all the sub-directories of the page at once. Figuring out how to configure it properly, render the flyout menu, and the pagination, definitely took some time. It was a good experience getting used to reading through Microsoft documentation.
3. The Model-View-ViewModel pattern. It isn't anything fancy, but I still consider it a good experience to have implemented it at least once.

## **How it's made**

The app was made in Xamarin.Forms using .NET 6 and C#:

- [XAML](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/xaml/?view=netdesktop-8.0) - Xml-based markup language;
- [Shell](https://learn.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/) - Reduces the complexity of mobile application development by providing the fundamental features that most mobile applications require.
- [MVVM](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) - Model-View-ViewModel pattern;

## **Main functionality**

- Flyout menu on the left. Two main pages, one for Tit birds, and one for Vultures;
- You can select from the available birds via a drop-down menu and then see the details about it;
- Single-tap to make the image fullscreen, and then double-tap to zoom-in futrher;
- One tap to un-zoom. Slide down to dismiss fullscreen or tap once when zoomed-out;
- At the footer of the flyout menu you can see the current date;
- Info page about the author.

## **Screenshots**

- A standard page, here showcasing the "Big Tit":
![image](https://github.com/4veti/BulgarianBirds/assets/37193765/3d7be805-f2e5-43aa-8474-ffd3a45d43cf)

- Here is the next image of the Big Tit, but brought to full screen and zoomed a little:
![image](https://github.com/4veti/BulgarianBirds/assets/37193765/5ef22256-0f9e-4b17-9069-c436eaba0933)

- This is the picker list of all birds:
![image](https://github.com/4veti/BulgarianBirds/assets/37193765/458ddff6-1b00-4d90-a794-71ed99d5dbbe)

- The flyout menu, showing the date at the bottom:
![image](https://github.com/4veti/BulgarianBirds/assets/37193765/199ae447-d976-42a6-a86a-046486384590)
