class ClientViewModel {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.contact = data.contact;
    this.phone = data.phone;
  }
}

let client = new ClientViewModel({
  id: 1,
  name: "Bob's Pizza",
  contact: "Brandon",
  phone: "555-1212"
});

