#include <SFML/Graphics.hpp>
#include <iostream>

const int windowWidth = 800, windowHeight = 800;

using namespace std;

int GameWithoutOOP()
{
    sf::Texture heroTexture = sf::Texture();
    heroTexture.loadFromFile("assets/hero.png");

    sf::Texture grassTexture = sf::Texture();
    grassTexture.loadFromFile("assets/grass.png");

    sf::Font font;
    font.loadFromFile("assets/BebasNeue-Regular.ttf");
    sf::Text text("Score: 0100", font);
    text.setCharacterSize(50);
    text.setStyle(sf::Text::Bold);
    text.setFillColor(sf::Color::White);
    text.setOutlineThickness(2);
    text.setOutlineColor(sf::Color::Black);
    text.setPosition(10, 0);

    
    sf::RenderWindow window(sf::VideoMode(windowWidth, windowHeight), "SFML works!");

    sf::RectangleShape grass = sf::RectangleShape(sf::Vector2f(windowWidth, windowHeight));
    grass.setTexture(&grassTexture);

    int heroWidth = 38, heroHeigth = 41;
    sf::Vector2f heroPos = sf::Vector2f(windowWidth / 2, windowHeight / 2);
    sf::IntRect heroRect = sf::IntRect(0, heroHeigth * 4, heroWidth, heroHeigth);
    sf::Sprite heroSprite = sf::Sprite(heroTexture, heroRect);
    heroSprite.setPosition(heroPos);
    heroSprite.scale(3,3);

    int heroAnimationCounter = 0;
    int heroSpeed = 5;

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::KeyPressed) {
                int actualSpeed = heroSpeed;

                if (event.key.shift)
                    actualSpeed *= 2;
                if (event.key.control)
                    actualSpeed /= 2;

                switch (event.key.code) {
                case sf::Keyboard::D:
                    heroRect.top = heroHeigth * 7;
                    heroRect.left = heroWidth * (heroAnimationCounter++ % 10);

                    heroPos.x += actualSpeed;
                    break;
                case sf::Keyboard::W:
                    heroRect.top = heroHeigth * 6;
                    heroRect.left = heroWidth * (heroAnimationCounter++ % 10);

                    heroPos.y -= actualSpeed;
                    break;
                case sf::Keyboard::A:
                    heroRect.top = heroHeigth * 5;
                    heroRect.left = heroWidth * (heroAnimationCounter++ % 10);

                    heroPos.x -= actualSpeed;
                    break;
                case sf::Keyboard::S:
                    heroRect.top = heroHeigth * 4;
                    heroRect.left = heroWidth * (heroAnimationCounter++ % 10);
                    
                    heroPos.y += actualSpeed;
                    break;
                }

                heroSprite.setTextureRect(heroRect);
                heroSprite.setPosition(heroPos);
            }

            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear();
        window.draw(grass);
        window.draw(heroSprite);
        window.draw(text);
        window.display();
    }

    return 0;
}