CREATE TABLE Event (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Description TEXT,
    EventDateTime TIMESTAMP NOT NULL,
    Location VARCHAR(255),
    Category VARCHAR(100),
    MaxParticipants INT,
    ImageUrl TEXT
);

CREATE TABLE Participant (
    Id SERIAL PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    DateOfBirth DATE,
    RegistrationDate TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Email VARCHAR(255) UNIQUE NOT NULL
);

-- Creatio of connection Event and Participant tales
CREATE TABLE EventParticipant (
    EventId INT NOT NULL REFERENCES Event(Id) ON DELETE CASCADE,
    ParticipantId INT NOT NULL REFERENCES Participant(Id) ON DELETE CASCADE,
    PRIMARY KEY (EventId, ParticipantId)
);
