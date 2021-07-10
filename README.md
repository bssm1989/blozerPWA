# Deploy Blazor to GitHub Pages

This [GitHub Action](https://github.com/features/actions) publishes and deploys a Blazor WebAssembly project in your repository to your [GitHub Pages](https://pages.github.com/) through the `gh-pages` branch. It can be seen used in the [`blazor-pwa-on-gh-pages`](https://github.com/proulxsamuel/blazor-pwa-on-gh-pages) sample.

This automatically performs all the required setup, including adding the `.nojekyll` file and a `404.html` page redirection workaround which is necessary in order for single-page applications to work in GitHub Pages.

This is based on [Steve Sanderson](https://github.com/SteveSandersonMS)'s [`BlazorOnGitHubPages`](https://github.com/SteveSandersonMS/BlazorOnGitHubPages) example.

# Usage

```yml
- uses: proulxsamuel/deploy-blazor-to-gh-pages@master
  with:
    # The path to the Blazor project in the repository.
    # Default: '.'
    project_path: ''   
```

This requires you to enable GitHub Pages in your repository settings and to checkout the repository through [`actions/checkout`](https://github.com/actions/checkout) first.

You can see a workflow example [here](https://github.com/proulxsamuel/blazor-pwa-on-gh-pages/blob/master/.github/workflows/deploy.yml).
