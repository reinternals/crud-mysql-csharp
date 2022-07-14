-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema rh
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema rh
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `rh` DEFAULT CHARACTER SET utf8 ;
USE `rh` ;

-- -----------------------------------------------------
-- Table `rh`.`region`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`region` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `region_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`country`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`country` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `country_name` VARCHAR(100) NOT NULL,
  `region_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_country_1_idx` (`region_id` ASC) ,
  CONSTRAINT `fk_country_1`
    FOREIGN KEY (`region_id`)
    REFERENCES `rh`.`region` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`location`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`location` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `street_address` VARCHAR(100) NOT NULL,
  `postal_code` VARCHAR(9) NOT NULL,
  `city` VARCHAR(45) NOT NULL,
  `state_province` VARCHAR(45) NULL,
  `country_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_location_1_idx` (`country_id` ASC) ,
  CONSTRAINT `fk_location_1`
    FOREIGN KEY (`country_id`)
    REFERENCES `rh`.`country` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`department`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`department` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `department_name` VARCHAR(50) NOT NULL,
  `manager_id` INT NULL,
  `location_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_department_1_idx` (`location_id` ASC) ,
  INDEX `fk_department_2_idx` (`manager_id` ASC) ,
  CONSTRAINT `fk_department_1`
    FOREIGN KEY (`location_id`)
    REFERENCES `rh`.`location` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_department_2`
    FOREIGN KEY (`manager_id`)
    REFERENCES `rh`.`employee` (`manager_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`job`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`job` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `job_title` VARCHAR(45) NOT NULL,
  `min_salary` FLOAT NULL,
  `max_salary` FLOAT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`employee` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(45) NOT NULL,
  `last_name` VARCHAR(45) NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `phone_number` VARCHAR(12) NULL,
  `hire_date` DATE NOT NULL,
  `job_id` INT NULL,
  `salary` FLOAT NOT NULL,
  `commission_pct` INT NULL,
  `manager_id` INT NULL,
  `department_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_employee_1_idx` (`department_id` ASC) ,
  INDEX `fk_employee_3_idx` (`job_id` ASC) ,
  INDEX `fk_employee_2_idx` (`manager_id` ASC) ,
  CONSTRAINT `fk_employee_1`
    FOREIGN KEY (`department_id`)
    REFERENCES `rh`.`department` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_employee_2`
    FOREIGN KEY (`manager_id`)
    REFERENCES `rh`.`employee` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_employee_3`
    FOREIGN KEY (`job_id`)
    REFERENCES `rh`.`job` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`job_history`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`job_history` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `employee_id` INT NOT NULL,
  `start_date` DATE NOT NULL,
  `end_date` DATE NULL,
  `job_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_job_history_1_idx` (`job_id` ASC) ,
  CONSTRAINT `fk_job_history_1`
    FOREIGN KEY (`job_id`)
    REFERENCES `rh`.`employee` (`job_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- Dados aleatórios para popular as tabelas.

-- REGION.
INSERT INTO region (region_name) VALUES ("North America");

-- COUNTRY.
INSERT INTO country (country_name, region_id) VALUES ("Mexico", 1);

-- LOCATION.
INSERT INTO location (street_address, postal_code, city, state_province, country_id) 
VALUES ("Mariano escoberdo", "11932", "Mexico city", "Distrito Federal", 1);

-- DEPARTMENT.
INSERT INTO department (department_name, manager_id, location_id) VALUES ("IT Helpdesk", null, 1);

INSERT INTO department (department_name, manager_id, location_id) VALUES ("Government Sales", null, 1);

INSERT INTO department (department_name, manager_id, location_id) VALUES ("Retail Sales", null, 1);

INSERT INTO department (department_name, manager_id, location_id) VALUES ("Recruiting", null, 1);

INSERT INTO department (department_name, manager_id, location_id) VALUES ("Payroll", null, 1);

-- JOB.
INSERT INTO job (job_title, min_salary, max_salary) VALUES ("President", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Administration Vice President", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Administration Assistant", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Finance Manager", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Accountant", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Accounting Manager", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Public Accountant", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Sales Manager", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Sales Representative", null, null);

INSERT INTO job (job_title, min_salary, max_salary) VALUES ("Purchasing Clerk", null, null);

-- EMPLOYEE
INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("jose", "ferreira", "josemail@gmail.com", "40028922", "2000-01-01", 1, 27000, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("joao", "ferreira", "joaomail@gmail.com", "40028922", "2000-02-02", 2, 2700, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("jesse", "alias", "jessemail@gmail.com", "40028922", "2000-03-03", 3, 7000, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("julio", "namememe", "juliomail@gmail.com", "40028922", "2000-04-04", 4, 27700, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("pedro", "oliver", "pedromail@gmail.com", "40028922", "2000-05-05", 5, 27011, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("henrique", "cris", "henriquemail@gmail.com", "40028922", "2000-06-06", 6, 2900, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("matt", "gustavino", "mattmail@gmail.com", "40028922", "2000-07-07", 7, 27400, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("andrew", "erickson", "andrewmail@gmail.com", "40028922", "2000-08-08", 8, 27001, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("carlos", "matias", "carlosmail@gmail.com", "40028922", "2000-09-09", 9, 27010, null, null, 1);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("jerilsom", "merigon", "josemail@gmail.com", "40028922", "2000-10-10", 1, 27000, null, null, 2);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("gui", "carlos", "josemail@gmail.com", "40028922", "2000-11-11", 1, 27000, null, null, 3);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("mecky", "musse", "josemail@gmail.com", "40028922", "2001-01-01", 1, 27000, null, null, 4);

INSERT INTO employee (first_name, last_name, email, phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id)
VALUES ("oliver", "queen", "josemail@gmail.com", "40028922", "2002-01-01", 1, 27000, null, null, 5);
