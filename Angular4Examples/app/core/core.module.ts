import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { HttpModule }    from '@angular/http';

import { NavBarComponent } from './navbar.component';

@NgModule({
    imports: [
        RouterModule,
        BrowserModule,
        FormsModule,
        HttpModule,
    ],
    declarations: [NavBarComponent],
    exports: [
        NavBarComponent,
        BrowserModule,
        FormsModule,
        HttpModule
    ]

})
export class CoreModule { }