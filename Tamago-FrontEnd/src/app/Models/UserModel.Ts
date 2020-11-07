export class UserModel {
  public id: String;

  public email: String;
  public password: String;

  constructor(email: String, password: String, id: String) {
    this.id = id;

    this.email = email;
    this.password = password;
  }
}
