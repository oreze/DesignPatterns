#include <iostream>
#include <string>

class Subject
{
public:
    virtual std::string getRequirements() = 0;
    virtual void pass() = 0;
    virtual void fail() = 0;

protected:
    std::string requirements;
    bool isPassed;
};

class Exam
{
public:
    Exam(Subject *subject);
    void pass();
    void fail();

protected:
    Subject *subject;
};

class Scrum : public Subject
{
public:
    Scrum(std::string requirements);
    void complainOnDoctorDaniluk();
    std::string getRequirements();
    void pass();
    void fail();
};

class FinalExam : public Exam
{
public:
    explicit FinalExam(Subject* subject) : Exam(subject) {}
    void cheat();
};

Exam::Exam(Subject *subject)
{
    this->subject = subject;
}

void Exam::pass()
{
    this->subject->pass();
}

void Exam::fail()
{
    this->subject->fail();
}

Scrum::Scrum(std::string requirements)
{
    this->requirements = requirements;
    this->isPassed = false;
}

void Scrum::complainOnDoctorDaniluk()
{
    std::cout << "No i ja się pytam człowieku dumny ty jesteś z siebie zdajesz sobie sprawę z tego" <<
    " co robisz?masz ty wogóle rozum i godność człowieka?Ja nie wiem ale żałosny typek z ciebie," <<
    " chyba nie pomyślałes nawet co robisz i kogo obrażasz, możesz sobie obrażac tych co na to zasłużyli" <<
    " sobie ale nie naszego doktora Daniluka naszego rodaka wielką osobę" << std::endl;
}

std::string Scrum::getRequirements()
{
    return this->requirements;
}

void Scrum::pass()
{
    this->isPassed = true;
    std::cout << "oh boi he passed (not away unfortunately)" << std::endl;
}

void Scrum::fail()
{
    this->isPassed = false;
    std::cout << "Mister Daniluku, noooooooooooooooooooooooooooo" << std::endl;
}

int main() {
    Subject* subject = new Scrum("referacik");
    Exam* exam = new FinalExam(subject);

    exam->pass();
    exam->fail();
}