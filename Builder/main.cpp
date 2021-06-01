#include <iostream>
#include <string>
#include <vector>

class Builder {
public:
	void virtual addUser() = 0;
	void virtual activateAcount() = 0;
	void virtual addPermissions() = 0;
};

class Director {
public:
	void runBuilder();
	Director(Builder* builder);
private:
	Builder* builder;
};

class User {
public:
	std::string login;
	User(std::string login, std::string password);
	void activate();
	void addPermission(std::string permission);
private:
	std::string password;
	bool activated;
	std::vector<std::string>* permissions;
};

class UserBuilder : public Builder {
public:
	User* getResult();
    void addUser() {
        this->result = new User("user", "password");
    }
	void activateAcount() {
        this->result->activate();
    }
	void addPermissions() {
        this->result->addPermission("read");
    }
private:
	User* result;
};

class AdminBuilder : public Builder {
public:
	User* getResult();
    void addUser() {
        this->result = new User("admin", "password");
    }
	void activateAcount() {
        this->result->activate();
    }
	void addPermissions() {
        this->result->addPermission("create");
        this->result->addPermission("read");
        this->result->addPermission("update");
        this->result->addPermission("delete");
    }
private:
	User* result;
};

void Director::runBuilder() {
    builder->addUser();
    builder->activateAcount();
    builder->addPermissions();
}

Director::Director(Builder* builder) {
    this->builder = builder;
}

User::User(std::string login, std::string password) {
    this->login = login;
    this->password = password;
    this->permissions = new std::vector<std::string>();
}

void User::activate() {
    this->activated = true;
}

void User::addPermission(std::string permission) {
    this->permissions->push_back(permission);
}

User* AdminBuilder::getResult() {
    return this->result;
}

User* UserBuilder::getResult() {
    return this->result;
}

int main() {
    UserBuilder* userBuilder = new UserBuilder();
    AdminBuilder* adminBuilder = new AdminBuilder();

    Director* userDirector = new Director(userBuilder);
    Director* adminDirector = new Director(adminBuilder);

    userDirector->runBuilder();
    adminDirector->runBuilder();
    User* user = userBuilder->getResult();
    User* admin = adminBuilder->getResult();

    std::cout << "Admin login: " << admin->login << std::endl;
    std::cout << "User login: " << user->login << std::endl;
}

