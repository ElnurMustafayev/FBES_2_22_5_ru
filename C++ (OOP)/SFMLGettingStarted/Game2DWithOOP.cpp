#include <SFML/Graphics.hpp>
#include <iostream>
using namespace std;

const int windowWidth = 800, windowHeight = 800;

#include "Showable.h"
#include "Text.h"
#include "Hero.h"

int mainnnn()
{
    sf::Texture heroTexture = sf::Texture();
    heroTexture.loadFromFile("assets/hero.png");

    sf::Texture grassTexture = sf::Texture();
    grassTexture.loadFromFile("assets/grass.png");

    sf::RenderWindow window(sf::VideoMode(windowWidth, windowHeight), "SFML works!");

    Aboba::Hero hero = Aboba::Hero(heroTexture, 38, 41, 5, 3);

    sf::RectangleShape grass = sf::RectangleShape(sf::Vector2f(windowWidth, windowHeight));
    grass.setTexture(&grassTexture);

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::KeyPressed) {
                hero.Go(event);
            }

            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear();
        window.draw(grass);
        hero.Show(window);
        window.display();
    }

    return 0;
}