import { Routes } from '@angular/router';

import { Cities } from './cities/cities';

export const routes: Routes = 
  [
    {path: "Cities", component: Cities},
    { path: "", redirectTo: "Cities", pathMatch: "full" }
];
