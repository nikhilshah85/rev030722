import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { FutureComponent } from './components/about/future/future.component';
import { OrganizatioonComponent } from './components/about/organizatioon/organizatioon.component';
import { ProjectComponent } from './components/about/project/project.component';
import { TeamComponent } from './components/about/team/team.component';
import { AddproductComponent } from './components/addproduct/addproduct.component';
import { CartComponent } from './components/cart/cart.component';
import { CommentsComponent } from './components/comments/comments.component';
import { ContactComponent } from './components/contact/contact.component';
import { HomeComponent } from './components/home/home.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { ProductlistComponent } from './components/productlist/productlist.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'home',component:HomeComponent},
  {path:'about',component:AboutComponent,children:[
    {path:'project',component:ProjectComponent},
    {path:'teams',component:TeamComponent},
    {path:'organization',component:OrganizatioonComponent},
    {path:'future',component:FutureComponent},
  ]},
  {path:'contact',component:ContactComponent},
  {path:'productlist',component:ProductlistComponent},
  {path:'addproduct',component:AddproductComponent},
  {path:'comments',component:CommentsComponent},
  {path:'cart',component:CartComponent}  
]; 
                          // --this is where u put all ur components and url

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
