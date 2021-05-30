#include <string>
#include <iostream>

class State {
public:
	void virtual handle() = 0;
};

class NPC {
public:
	NPC(std::string name);
	State* state;
    void wakeUp();
    void kill();
private:
	std::string name;
};

class Alive : public State {
public:
	void Kill(NPC* npc);
    void handle() {
        std::cout << "NPC IS IN STATE ALIVE" << std::endl;
    }
};

class Dead : public State {
public:
	void WakeUp(NPC* npc);
    void handle() {
        std::cout << "NPC IS IN STATE DEAD" << std::endl;
    }
};

NPC::NPC(std::string name) {
    this->name = name;
    this->state = new Alive();
}

void NPC::kill() {
    std::cout << "Killing npc" << std::endl;
    this->state = new Dead();
}

void NPC::wakeUp() {
    std::cout << "Waking up npc" << std::endl;
    this->state = new Alive();
}

int main() {
    NPC* npc1 = new NPC("Jonasz1");
    NPC* npc2 = new NPC("Jonasz2");

    npc2->state->handle();
    npc1->state->handle();
    npc1->kill();
    npc2->state->handle();
    npc1->state->handle();
}




