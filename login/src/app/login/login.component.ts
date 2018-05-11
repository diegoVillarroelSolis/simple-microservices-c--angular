import { Component } from '@angular/core';
import { User } from './user.model';
import { LoginService } from './login.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent {
    private state: any;
    //private user: User;
    user = new User();
    constructor(private loginService: LoginService) { }

    public validate(user: string, password: string){
        this.loginService.validate(user, password).subscribe(
            data => {this.state=data; console.log(this.state)},
            err => console.log(err),
            () => console.log("Validating user")
        );        
    }
}