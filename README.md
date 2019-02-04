# README

An AR project about virtual ACG role

The animation part is designed by Lu Chen

The WebAR animation & music part are designed by @[Pomevak](https://github.com/Pomevak)



## 1.How to run our project

### 1.1 For Android version

- Install our application use **misaki_ar.apk**

- Open mistaki_ar,use your camera to focus on the target image

  (You can also use unity ios develop tool to built a ios version directly)

  ![](https://github.com/Dinghow/Misaki_AR/raw/master/img/1.jpg)

### 1.2 For WebAR version

You don't need to install any application for this version, based on [AR.js](https://github.com/jeromeetienne/AR.js), you can download this 	respositroy and deploy the web version on your server, then you can use any browser to open your page, focus on the new marker

![](https://jeromeetienne.github.io/AR.js/data/images/HIRO.jpg)



- You will see Misaki

![](https://github.com/Dinghow/Misaki_AR/raw/master/img/2.png)

- You can click "语音指令",and say some instructions like "跳个舞吧","Misaki酱，请跳舞","M酱，唱首歌吧"，then Misaki will do related behaviors
- You can click the buttons to control Misaki directly
- You can use finger style to adjust Misaki's position and size

![](https://github.com/Dinghow/Misaki_AR/raw/master/img/3.png)

## 2.Development environment

### 2.1 Android Version

Platform：Windows10 version1803

IDE：Android Studio 3.1.3/Unity2018.1.8f1

Kits:Xunfei Voice Recognition,Vuforia

SDK Tools Version:26.1.1

minSDKVersion: 16

targetSDKVersion: 26



### 2.2 WebAR Version

Frame: AR.js

Model: gltf

Speech recognition: [Annyang](https://github.com/TalAter/annyang)