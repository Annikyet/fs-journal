# Single Page Applications with Vue

**1.** What is the entrypoint of an application?
<!-- enter you answer in the space below -->
```
index.html > main.js > App.vue
```
**2.** What is the difference between a vue `component` and `page`?
<!-- enter you answer in the space below -->
```
A component is a module that is less than a full page. A page is... a page.
```
**3.** What feature of Vue can be used to repeat an element using a collection of data?
<!-- enter you answer in the space below -->
```
:v-for="c in collection"
```
**4.** What are the three tags that make up a Vue component?
<!-- enter you answer in the space below -->
```
<template> <script> <style>
```
**5.** What does the `L` represent in the `SOLID` principles?
<!-- enter you answer in the space below -->
```
Liskov Substitution Principle
(I still don't understand what it means)
```
**6.** Which component in Vue does the vue-router use to mount pages onto?
<!-- enter you answer in the space below -->
```
loadPage?
```
**7.** What is the difference between the `AppState` and the state object within a component?
<!-- enter you answer in the space below -->
```
AppState is globally scoped, state is global only to the component/page
```
**9.** What is the responsibility of `Services` in our Vue projects?
<!-- enter you answer in the space below -->
```
The same as MVC, to update information in the AppState and communicate with the API.
```
**10.** Which file contains the root element of your Vue project?
<!-- enter you answer in the space below -->
```
Vue.app
```
**11.** The ______ tag is used to alter the styling of your entire Vue project.  Adding the ______ attribute to this tag will limit it to just the component it exists.  Fill in the blank.
<!-- enter you answer in the space below -->
```
scoped?
```
**12.** What is the Vue method used to create watchable objects such as `state` or `AppState`?
<!-- enter you answer in the space below -->
```
reactive()?
```