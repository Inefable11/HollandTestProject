// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  /*apiUrl: 'http://walter150976-001-site2.dtempurl.com',
  api: 'http://walter150976-001-site2.dtempurl.com/api',
  urlFoto:'http://walter150976-001-site2.dtempurl.com/user/'*/
  apiUrl: 'https://localhost:44390/',
  api: 'https://localhost:44390/api',
  urlFoto:'https://localhost:44390/user/'
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.