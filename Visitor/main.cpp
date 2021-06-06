#include <iostream>
#include <string>

// Handle circular dependencies
class Visitor;
class City;
class Village;

class Place {
public:
    std::string name;
    Place(std::string name);
	virtual void build() = 0;
	virtual void accept(Visitor* visitor) = 0;
};

class Visitor {
public:
    std::string name;
    Visitor(std::string name);
	virtual void visitCity(City* city) = 0;
	virtual void visitVillage(Village* village) = 0;
};

class City : public Place {
public:
    explicit City(std::string name): Place(name) {}
	void build();
	void accept(Visitor* visitor);
};

class Village : public Place {
public:
    explicit Village(std::string name): Place(name) {}
	void build();
	void accept(Visitor* visitor);
};

class Tornado : public Visitor {
public:
    explicit Tornado(std::string name): Visitor(name) {}
    void visitCity(City* city);
    void visitVillage(Village* village); 
};

Place::Place(std::string name) {
    this->name = name;
}

Visitor::Visitor(std::string name) {
    this->name = name;
}

void Tornado::visitCity(City* city) {
    city->accept(this);
}

void Tornado::visitVillage(Village* village) {
    village->accept(this);
}

void City::build() {
    std::cout << "City builded" << std::endl;
}

void City::accept(Visitor* visitor) {
    std::cout << "City " << this->name << " visited by " << visitor->name << std::endl;
}

void Village::build() {
    std::cout << "Village builded" << std::endl;
}

void Village::accept(Visitor* visitor) {
    std::cout << "Village " << this->name << " visited by " << visitor->name << std::endl;
}

int main() {
    Tornado* tornado = new Tornado("D*niluk");

    Village* village = new Village("Lublin");
    City* city = new City("Świdnik");

    tornado->visitCity(city);
    tornado->visitVillage(village);
}