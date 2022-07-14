-- Criando novo usuario para o banco de dados.

CREATE USER 'hr'@'localhost' IDENTIFIED BY 'hr';

GRANT ALL PRIVILEGES ON *.* TO 'hr'@'localhost';

FLUSH PRIVILEGES;