# Setup

After creating vite project, run this to install and init tailwind and postcss

```
npm install -D tailwindcss postcss autoprefixer
npx tailwindcss init -p
```

Add a path to the index.html and Vue modules to `./tailwind.config.js`:
```js
/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.vue"
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}
```

Create `./src/index.css` and import the Tailwind layers:
```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

Add link to `./src/index.css` inside of `./src/main.js`:
```js
import './index.css'
```

# Applying Styling
Just add the appropriate utility classes to tags.

# Custom Styling
Simply use square brackets to force a custom value:
```
class="top-[117px]"
```

# Re-using Styling
For small, widely re-used components, use the `@apply` tag to apply utility classes in `index.css`. `@apply` can also be combined with vanilla CSS rules.

Inside `index.css`:
```css
@layer components {
  .mint-bg {
    @apply bg-green-300;
    color: #002010;
  }
}
```