export class InventoryModel {
  public id: String;
  public userId: String;

  public itemId: String[];

  constructor(id: String, userId: String, itemId: String[]) {
    this.id = id;
    this.userId = userId;
    this.itemId = itemId;
  }
}
