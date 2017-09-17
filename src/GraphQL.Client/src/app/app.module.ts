import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ApolloModule } from 'apollo-angular';
import { ApolloClient, createNetworkInterface } from 'apollo-client';

import { AppComponent } from './app.component';

export function provideClient(): ApolloClient {
  return new ApolloClient({
    networkInterface: createNetworkInterface({
      uri: 'http://localhost:5000/api/graphql'
    }),
  });
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    ApolloModule.forRoot(provideClient),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
