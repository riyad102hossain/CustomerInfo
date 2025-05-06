import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { APP_ROUTE_PROVIDER } from './route.provider';
import { CoreModule, provideAbpCore, withOptions } from '@abp/ng.core';
import { registerLocale } from '@abp/ng.core/locale';
import { provideAbpThemeShared, ThemeSharedModule } from '@abp/ng.theme.shared';
import { ThemeLeptonXModule } from '@abp/ng.theme.lepton-x';


import { provideFeatureManagementConfig } from '@abp/ng.feature-management';
import { provideAbpOAuth } from '@abp/ng.oauth';
import { provideIdentityConfig } from '@abp/ng.identity/config';
import { provideSettingManagementConfig } from '@abp/ng.setting-management/config';
import { provideTenantManagementConfig } from '@abp/ng.tenant-management/config';
import { provideAccountConfig } from '@abp/ng.account/config';

// Import CustomerComponent
import { CustomerComponent } from './customer/customer.component'; // Correct path

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    CoreModule,
    ThemeSharedModule,
    ThemeLeptonXModule.forRoot(), // Correct usage
    SideMenuLayoutModule.forRoot(),
    AccountLayoutModule.forRoot(),
    CustomerComponent,   // Keep the import for potential usage in templates/routing
  ],
  declarations: [
    AppComponent,
    // Remove CustomerComponent from declarations
  ],
  providers: [
    APP_ROUTE_PROVIDER,
    provideAbpCore(
      withOptions({
        environment,
        registerLocaleFn: registerLocale(),
      })
    ),
    provideAbpOAuth(),
    provideAbpThemeShared(),
    provideSettingManagementConfig(),
    provideAccountConfig(),
    provideIdentityConfig(),
    provideTenantManagementConfig(),
    provideFeatureManagementConfig(),
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}