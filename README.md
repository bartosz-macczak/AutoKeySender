# AutoKeySender - send digital goods automatically
Simple desktop app to to send digital items to your customers on Allegro
## Table of Contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is a desktop app who can send cd-keys, accounts, informations and other digital items to your customers who bought someting from you on Allegro. You can create templates of your messages, data bases with your items and link them with your auctions on Allegro.
	
## Technologies
Project is created with:
* C#
* .NET Framework
* Windows Forms
* MySQL
* RestSharp
* Json.NET

	
## Setup
To run this project 
Edit variables:
* DataBaseClass.cs
```
globalConnDetails = "datasource=localhost;database=autokeysender;port=3306;username=root;password="
```
* ManageOrdersClass.cs
```
public void sendCode (string email, string message)
        {
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            ...
            client.Credentials = new System.Net.NetworkCredential("...@gmail.com", "password");

            MailMessage mm = new MailMessage("...@gmail.com", email,"Title of message", message);
            ...
        }
```
Compile and run

### To Do:
* Run public server with data base
* Sending images as items
* eBay integration
* Web application in ASP.NET Core MVC

### Inspiration
Functions of my app are inspired by the automater.pl
