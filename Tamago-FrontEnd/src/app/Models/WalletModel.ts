export class WalletModel {
  public id: String;
  public userId: String;

  public balance: number;

  constructor(id, userId, balance) {
    this.id = id;
    this.userId = userId;
    this.balance = balance;
  }
}
