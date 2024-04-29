import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'E_Commerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44350/',
    redirectUri: baseUrl,
    clientId: 'E_Commerce_App',
    responseType: 'code',
    scope: 'offline_access E_Commerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44396',
      rootNamespace: 'E_Commerce',
    },
  },
} as Environment;
