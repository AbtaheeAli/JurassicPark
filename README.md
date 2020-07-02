# JurassicPark

![Kapture 2020-07-02 at 16 32 10](https://user-images.githubusercontent.com/62678918/86406728-a7c91e00-bc81-11ea-82a8-c4ef47fbc9eb.gif)

Languages & Technologies Used: C# & LINQ

A zoo application that prompts the user a menu selection and allows them to manage a zoo of dinosaurs

A class of Dinosaurs is created to get and set the following:

- Name
- Diet Type
- When Acquired: Default to the current time when the
  dinosaur is created
- Weight
- Enclosure Number - the number of the pen the dinosaur is currently in
- Description method: Prints out a description of the dinosaur to include all of its properties

The dinosaurs are stored in a List after they are created

When the console application runs, it displays a menu that allows the user to choose from one of the following actions:

- View: This command shows all the dinosaurs in the list, ordered by WhenAcquired
- Add: This command will let the user type in the information for a dinosaur and add it to the list
- Remove: This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
- Transfer
  This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
- Summary: This command will display the number of carnivores and the number of herbivores.
- Quit: This will stop the program
