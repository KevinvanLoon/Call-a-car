import { NgModule } from "@angular/core";
import {DropdownModule} from 'primeng/dropdown';
import {InputTextModule} from 'primeng/inputtext';
import {MultiSelectModule} from 'primeng/multiselect';
import {PasswordModule} from 'primeng/password';
import {FieldsetModule} from 'primeng/fieldset';
import {TooltipModule} from 'primeng/tooltip';
import {InputTextareaModule} from 'primeng/inputtextarea'

@NgModule({
    imports : [InputTextareaModule,  DropdownModule,MultiSelectModule,InputTextModule,PasswordModule,FieldsetModule,TooltipModule],
    exports : [InputTextareaModule,  DropdownModule,MultiSelectModule,InputTextModule,PasswordModule,FieldsetModule,TooltipModule],
})

export class NgPrimeModule{}