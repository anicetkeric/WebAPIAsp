# WebAPIAsp
Création d’un service RESTful avec ASP.NET Web API

ASP.NET Web API est une infrastructure qui facilite le développement de services HTTP disponibles sur un large éventail de clients, tels que des navigateurs et des appareils mobiles. ASP.NET Web API est la plateforme idéale pour développer des applications RESTful sous .NET Framework. 

## Prérequis
*	Microsoft Visual Studio 2013 ou supérieur 
* Postman pour tester notre API: https://www.getpostman.com/apps

## Création du projet ASP WEB API

1. Démarrer Visual Studio.
2. Fichier > Nouveau > Projet
3. Visual C# et sélectionnez Web, puis **Application Web ASP.NET**. Nommez l'application **WebAPIAsp**, puis cliquez sur OK.

![capture 1](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/1.PNG)

* Sélectionnez le **Modèle Vide** et avec l'option **Web API** de cochée. Décochez également la case **Hôte dans le cloud** puis cliquez sur OK.
![capture 2](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/2.PNG)

* La structure du projet est la suivante:

![capture 3](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/3.PNG)

Après avoir créé le projet d'API Web ASP.NET, la structure de dossiers et les fichiers précédents sont ajoutés au projet par défaut, qui sont identiques au projet MVC. Par conséquent, nous allons en apprendre quelques mots en bref comme suit:

**App_Start**

Ce dossier contient les détails de configuration de l'application tels que le routage, l'authentification, le filtrage de l'URL et ainsi de suite.

**Controllers**

Ce dossier contient le contrôleur et leurs méthodes. Le contrôleur est responsable du traitement de la demande de l'utilisateur et retourne la sortie sous la forme d'une vue.

**Models**

Ce dossier contient les entités ou propriétés utilisées pour stocker les valeurs d'entrée.


## Ajouter un modèle
![capture 4](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/4.PNG)

![capture 5](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/5.PNG)

## Ajouter un contrôleur

![capture 6](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/6.PNG)

![capture 7](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/7.PNG)



![capture 8](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/8.PNG)

![capture 9](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/9.PNG)


## Test avec postman

Demarrer l'application. 	

| Action        | HTTP method   |URI  |
| ------------- |:-------------:| -----:|
| Ajouter un livre    | POST | api/book/AddBook/{book} |
| Liste des livres     | GET      |  api/book/GetAllBooks/ |
| Selectionner un livre | GET     |    api/book/GetBook/{id} |
| Supprimer un livre |DELETE      |   api/book/DeleteBook/{idBook} |
| Modifier un livre | PUT     |   api/book/UpdateBook/{book}|


![capture 10](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/10.PNG)

![capture 11](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/11.PNG)

![capture 12](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/12.PNG)

![capture 13](https://github.com/anicetkeric/WebAPIAsp/blob/master/WebAPIAsp/screen/13.PNG)
