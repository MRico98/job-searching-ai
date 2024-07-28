# Textual Description of Each Process in the Business Model

## 1. **Frontend**
   - **User accesses the frontend**: The user enters the system through the user interface.
   - **Retrieve job postings from the database via API**: The interface retrieves job postings from the database via an API.
   - **Show job postings to the user**: The job postings are displayed to the user in the interface.
   - **User selects a job**: The user selects a specific job offer to see more details.
   - **Show job details**: The details of the selected job offer are displayed.
   - **User requests AI recommendation**: The user requests a personalized AI-generated recommendation to improve their chances of success in the interview.

## 2. **Middleware**
   - **Send recommendation request to AI platform**: A recommendation request is sent to the AI platform.
   - **Notify user that recommendation is being processed**: The user is notified that their recommendation request is being processed.
   - **Queue recommendation request**: The recommendation request is queued to be processed by the AI.
   - **Store recommendations in the database**: The AI-generated recommendations are stored in the database.
   - **Retrieve generated recommendation from database**: The generated recommendation is retrieved from the database.
   - **Notify user that recommendation is ready**: The user is notified that their recommendation is ready for review.

## 3. **RabbitMQ**
   - **Process recommendation request**: The queued recommendation request is processed by RabbitMQ.

## 4. **Ollama Service**
   - **AI platform processes recommendation**: The AI platform processes the recommendation request.
   - **Generate roadmap and recommendations**: The AI platform generates a roadmap and personalized recommendations based on the job description.

## 5. **Frontend (continued navigation)**
   - **User still being able to navigate web page and generate new recommendations**: The user can continue navigating the website and generate new recommendation requests while the previous recommendation is being processed.

## 6. **Web Scraping Service**
   - **Daily web scraping from LinkedIn**: A daily web scraping process retrieves job postings from LinkedIn.
   - **Update job postings in the database**: The retrieved job postings are updated in the database.