export interface ILoginVm {
  userName: string;
  password: string;
}

export interface IRegisterVm {
  userName: string;
  password: string;
  confirmPassword: string;
  rememberMe: boolean;
  facility: string;
  team: string;
}
