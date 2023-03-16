#include <SFML/Graphics.hpp>
#include <iostream>

using namespace std;

int MMain() {
    /*
    */
    const string imagePath = "assets\\cat.jpg";

    srand(time(0));
    sf::Vector2i windowSize = sf::Vector2i(800, 500);
    sf::RenderWindow window(sf::VideoMode(windowSize.x, windowSize.y), "SFML works!");

    sf::Vector2f rectSize = sf::Vector2f(200, 200);
    sf::Vector2f rectPos = sf::Vector2f((windowSize.x / 2) - (rectSize.x / 2), (windowSize.y / 2) - (rectSize.y / 2));
    sf::RectangleShape rectangle = sf::RectangleShape(rectSize);
    rectangle.setPosition(rectPos);
    rectangle.setOrigin(rectSize.x / 2, rectSize.y / 2);

    sf::Texture texture = sf::Texture();
    texture.loadFromFile(imagePath);
    rectangle.setTexture(&texture);

    //rectangle.setOutlineColor(sf::Color::Red);
    //rectangle.setOutlineThickness(10);

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

        rectangle.rotate(0.05);

        window.clear(sf::Color::Black);
        window.draw(rectangle);
        window.display();
    }

    return 0;
}