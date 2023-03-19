# eRent

Credentials
Desktop app

    Administrator

    Username: desktop             
    Password: admin                                      

Mobile app

    Customer

    Username: mobile                        
    Password: admin     

    Customer 2

    Username: desktop
    Password: admin  

Running the app

Open a terminal inside the solution folder and use following commands (API+DB):

    docker-compose build
    docker-compose up

To start the mobile app, from the root folder navigate to mobile -> myapp and run:

    flutter pub get
    flutter run

Stripe test card number:

    4242 4242 4242 4242

Start the windows app inside visual studio IDE. (If not selected, set the startup project to eRent.UI)

To recive FCM notifications your AVD need to have Google Play Services. (The time to recive a notification can vary.)
