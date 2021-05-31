#include <iostream>
#include <string>

class Expression {
public:
	bool virtual interpret(std::string context) = 0;
};

class TerminalExpression : public Expression {
public:
	std::string data;
	TerminalExpression(std::string data);
    bool interpret(std::string context);
};

class OrExpression : public Expression {
public:
	TerminalExpression* expression1;
	TerminalExpression* expression2;
	OrExpression(TerminalExpression* expression1, TerminalExpression* expression2);
    bool interpret(std::string context);
};

class AndExpression : public Expression {
public:
	TerminalExpression* expression1;
	TerminalExpression* expression2;
	AndExpression(TerminalExpression* expression1, TerminalExpression* expression2);
    bool interpret(std::string context);
};

TerminalExpression::TerminalExpression(std::string data) {
    this->data = data;
}

bool TerminalExpression::interpret(std::string context) {
    return context.find(this->data) != std::string::npos;
}

AndExpression::AndExpression(TerminalExpression* expression1, TerminalExpression* expression2) {
    this->expression1 = expression1;
    this->expression2 = expression2;
}

bool AndExpression::interpret(std::string context) {
    return this->expression1->interpret(context) && this->expression2->interpret(context);
}

OrExpression::OrExpression(TerminalExpression* expression1, TerminalExpression* expression2) {
    this->expression1 = expression1;
    this->expression2 = expression2;
}

bool OrExpression::interpret(std::string context) {
    return this->expression1->interpret(context) || this->expression2->interpret(context);
}

int main() {
    TerminalExpression* student = new TerminalExpression("Student");
    TerminalExpression* dziekan = new TerminalExpression("Dziekan");

    AndExpression* andExp = new AndExpression(student, dziekan);
    std::cout << "Student Piwo = " <<  andExp->interpret("Student Piwo") << std::endl;
    std::cout << "Student Dziekan Piwo = " <<  andExp->interpret("Student Dziekan Piwo") << std::endl;
    
    std::cout << "OR" << std::endl;
    OrExpression* orExp = new OrExpression(student, dziekan);
    std::cout << "Student Piwo = " << orExp->interpret("Student Piwo") << std::endl;
    std::cout << "Student Dziekan Piwo = " << orExp->interpret("Student Dziekan Piwo") << std::endl;
    std::cout << "Rektor Piwo = " << orExp->interpret("Rektor Piwo") << std::endl;
}