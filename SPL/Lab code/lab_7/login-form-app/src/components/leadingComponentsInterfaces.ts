
export interface ILoginForm{
    email:string,
    password:string;
}

export interface IValidationErrors {
    [key: string]: string | undefined;
}

export interface IRegistrationForm {
    name: string;
    email: string;
    password: string;
    confirmPassword: string;
}

export interface IResetPasswordForm{
    email:string;
}

