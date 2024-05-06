# Tweeting Tweets Blazor Project

This project is a simple Blazor application that allows users to post tweets and view a list of tweets. It utilizes MediatR for handling commands and queries, enabling clean separation of concerns and easy integration of new features.

## Features

- **Post Tweets:** Users can submit tweets using a simple form.
- **View Tweets:** Users can view a list of tweets posted by themselves and other users.
- **Clean Architecture:** The project follows a clean architecture approach, separating concerns into feature-specific folders.

## Getting Started

To run the project locally, follow these steps:

1. Clone this repository to your local machine:

    ```bash
    git clone <repository-url>
    ```

2. Navigate to the project directory:

    ```bash
    cd TweetingTweetsBlazorProject
    ```

3. Install the required dependencies:

    ```bash
    dotnet restore
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

5. Open your web browser and navigate to `https://localhost:5001` to view the application.

## Project Structure

The project structure follows a feature-based organization:

- **Pages:** Contains the Blazor components representing different pages of the application.
- **Features:** Contains feature-specific folders such as `Tweets` for handling tweet-related functionalities.
- **Data:** Contains data models and repositories for managing tweet data.
- **Shared:** Contains shared components, layouts, and resources used across the application.

## Technologies Used

- **Blazor:** A web framework for building interactive web UIs using C# instead of JavaScript.
- **MediatR:** A simple mediator implementation in .NET for implementing the mediator pattern in applications.
- **Bootstrap:** A popular CSS framework for building responsive and mobile-first websites.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes and commit them (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
