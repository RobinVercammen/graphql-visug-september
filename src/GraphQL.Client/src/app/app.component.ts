import { Component, OnInit } from '@angular/core';
import { Apollo, ApolloQueryObservable } from 'apollo-angular';
import gql from 'graphql-tag';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/switchMap';
import { Observable } from 'rxjs/Observable';

const GetHuman = gql`
query getHuman($idValue: String!) {
  human(id: $idValue) {
    __typename
    name
    homePlanet
    appearsIn
    friends {
      name
    }
  }
}
`;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  id$ = new Subject<number>();
  data: Observable<{}>;
  constructor(private apollo: Apollo) {

  }
  ngOnInit() {
    this.data = this.id$.switchMap(i => this.apollo.watchQuery({
      query: GetHuman,
      variables: {
        idValue: i + ''
      }
    }));
  }
  change(ev) {
    const id = +ev.target.value;
    this.id$.next(id);
  }
}
