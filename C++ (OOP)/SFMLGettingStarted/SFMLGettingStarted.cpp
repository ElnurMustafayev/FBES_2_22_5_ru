#include <SFML/Graphics.hpp>
#include <iostream>

using namespace std;

int MMMain()
{
    const string imagePath = "assets\\dvd.png";
    srand(time(0));
    sf::Vector2i windowSize = sf::Vector2i(800, 500);
    sf::RenderWindow window(sf::VideoMode(windowSize.x, windowSize.y), "SFML works!");

    sf::Vector2f rectSize = sf::Vector2f(150, 100);
    sf::Vector2f rectPos = sf::Vector2f(0, 0);
    sf::RectangleShape rectangle = sf::RectangleShape(rectSize);
    rectangle.setPosition(rectPos);

    sf::Texture texture = sf::Texture();
    texture.loadFromFile(imagePath);
    rectangle.setTexture(&texture);

    float directionX = 0.1, directionY = 0.1;
    float speed = 0.5;

    while (window.isOpen())
    {
        sf::Event event;

        while (window.pollEvent(event))
        {
            switch (event.type)
            {
            case sf::Event::Closed:
                cout << "Goodbye!" << endl;
                window.close();
                break;
            }
        }
        // Y
        if (rectPos.y <= 0) {
            directionY = speed;
        }
        else if (rectPos.y >= (windowSize.y - rectSize.y)) {
            directionY = -speed;
        }

        // X
        if (rectPos.x <= 0) {
            directionX = speed;
        }
        else if (rectPos.x >= (windowSize.x - rectSize.x)) {
            directionX = -speed;
        }

        rectPos.x += directionX;
        rectPos.y += directionY;

        rectangle.setPosition(rectPos);
        rectangle.rotate(0.5);

        window.clear(sf::Color::White);
        window.draw(rectangle);
        window.display();
    }

    return 0;
}