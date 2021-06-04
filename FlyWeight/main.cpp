#include <iostream>
#include <string>
#include <vector>

class Texture {
public:
	Texture(std::string name, std::string color);
    std::string name;
	std::string color;
};

class Tile {
public:
	Tile(int x, int y, Texture* texture);
private:
	int x;
	int y;
	Texture* texture;
};

class TextureFactory {
public:
    TextureFactory();
	Texture* createTexture(std::string name, std::string color);
private:
	std::vector<Texture*>* textures;
};

class Game {
public:
    Game(TextureFactory* textureFactory);
	void setTile(int x, int y, Texture* texture);
private:
	TextureFactory* textureFactory;
	std::vector<Tile*>* floor;
};

Texture::Texture(std::string name, std::string color) {
    this->name = name;
    this->color = color;
}

Tile::Tile(int x, int y, Texture* texture) {
    this->x = x;
    this->y = y;
    this->texture = texture;
}

TextureFactory::TextureFactory() {
    this->textures = new std::vector<Texture*>();
}

Texture* TextureFactory::createTexture(std::string name, std::string color) {
    this->textures->push_back(new Texture(name, color));
    return this->textures->back();
}

Game::Game(TextureFactory* textureFactory) {
    this->textureFactory = textureFactory;
    this->floor = new std::vector<Tile*>();
}

void Game::setTile(int x, int y, Texture* texture) {
    floor->push_back(new Tile(x, y, texture));
    std::cout << "Created new texture at " << x << " and " << y << " with texture " << 
        texture->name << ", color " << texture->color << std::endl;
}


int main() {
    TextureFactory* factory = new TextureFactory();
    Game* game = new Game(factory);

    Texture* texture1 = factory->createTexture("texture1", "ffffff");
    Texture* texture2 = factory->createTexture("texture2", "000000");
    game->setTile(0, 0, texture1);
    game->setTile(0, 1, texture1);
    game->setTile(1, 0, texture2);
    game->setTile(1, 1, texture2);
}
