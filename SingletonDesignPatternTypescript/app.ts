
class Database {
    private constructor() {
        console.log("nesne �retildi");
    }
    static _database: Database;
    static get getInstance() {
        if (this._database == null) {
            this._database = new Database();
        }
        return this._database;
    }
}


var d1: Database = Database.getInstance;

console.log(d1);