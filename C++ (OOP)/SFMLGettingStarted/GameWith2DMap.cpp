#include <SFML/Graphics.hpp>
#include <iostream>
using namespace std;

const int windowWidth = 800, windowHeight = 800;

int main()
{
    int mapElementWidth = 80, mapElementHeight = 80;
    const int mapX = 10, mapY = 10;
    int map[mapY][mapX]{
        {1,1,1,1,1,1,1,1,1,0},
        {1,1,1,1,1,1,1,1,1,0},
        {1,1,1,1,1,1,1,7,1,0},
        {1,1,1,1,1,1,1,7,1,0},
        {1,1,1,1,1,1,1,7,1,0},
        {1,1,1,1,1,1,1,7,1,6},
        {1,1,1,1,1,1,1,1,1,6},
        {1,1,1,1,1,1,1,1,1,6},
        {1,1,1,1,1,1,6,6,6,6},
        {1,1,1,1,1,1,1,1,1,0},
    };

    sf::Texture mapTexture = sf::Texture();
    mapTexture.loadFromFile("assets/map.png");

    auto heroRect = sf::IntRect(9 * mapElementWidth, 1 * mapElementHeight, mapElementWidth, mapElementHeight);

    sf::Sprite heroSprite = sf::Sprite(mapTexture, heroRect);
    heroSprite.scale(1.2, 1.2);


    sf::RenderWindow window(sf::VideoMode(windowWidth, windowHeight), "SFML works!");

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear();

        for (int i = 0; i < mapY; i++)
        {
            for (int j = 0; j < mapX; j++)
            {
                int currentElement = map[i][j];


                auto rect = sf::IntRect((currentElement % 6) * mapElementWidth, (currentElement / 6) * mapElementHeight, mapElementWidth, mapElementHeight);

                sf::Sprite sprite = sf::Sprite(mapTexture, rect);
                sprite.setPosition(mapElementWidth * j, mapElementHeight * i);
                window.draw(sprite);
            }
        }

        window.draw(heroSprite);
        window.display();
    }

    return 0;
}