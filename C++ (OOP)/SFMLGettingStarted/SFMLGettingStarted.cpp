#include <SFML/Graphics.hpp>
#include <iostream>

using namespace std;

int main()
{
    sf::RenderWindow window(sf::VideoMode(400, 200), "SFML works!");
    int counter = 0;

    while (window.isOpen())
    {
        sf::Event event;

        while (window.pollEvent(event))
        {
            switch (event.type)
            {
            case sf::Event::MouseButtonPressed:
                system("cls");
                cout << "Mouse button pressed count: " << ++counter << endl;
                break;
            case sf::Event::Closed:
                cout << "Goodbye!" << endl;
                window.close();
                break;
            }
        }

        window.display();
    }
}