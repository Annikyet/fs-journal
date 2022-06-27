# MVC

Setting up `vue.js`
```
bcw create
> vue starter
```

`vite` is an alternative transpiler used by bcw template to `webpack` (used by Vue.js CLI). (A little faster)

Everything is injected in `#app`.

`.vue` are Vue.js files

`sass`/`scss` auto-compiles with vite/webpack

Vue applications have three components:
1) HTML Template
```html
<Template>
  <header>
    <h1>{{greeting}}</h1>
  </header>
  <main>
    <button @click="do.code()">clicky!</button>
  </main>
  <footer>
  </footer>
</Template>
```
2) JS Script
```
<script>
  console.log('hi i'm javascript')
</script>
```

3) SCSS(?)

```css
  <style>
  #meow {
    color: white;
  }
  </style>
```

`./pages` for different pages.

`npm audit fix`

`vite`/`vue.js` supports hot updating (no refresh/respin required)

```js
export default {
  name: "Home",
  setup() {
    let greeting = 'meow';
    return {
      greeting
    };
  }
};
```

`setup()` is the main function(?)

`return{}` specified the variables to be injected in the HTML component using `{{variable}}`.

`@click="do.code()"` adds an `onclick`.

```js
import { ref } from "vue";
```

`ref` is the reference
```js
let index = ref(0);
```
 attaches a listener(?) to enable reactivity(?)

```
:style="'width:' + boss.health + '%'"
```

`ref` requires `boss.value.health` not `boss.health`.


```
v-for="hero in heroes"
```

`v-*` means a Vue attribute.

`computed()`

`.every()`
iterates over every element until condition is false or end of array.(?)

router to router doesn't auto refresh in the "same" page