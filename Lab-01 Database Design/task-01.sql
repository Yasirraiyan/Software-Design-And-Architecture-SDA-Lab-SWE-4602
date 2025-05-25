CREATE TABLE change_log 
(
    id SERIAL PRIMARY KEY,
    applied_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    created_by VARCHAR(100),
    script_name VARCHAR(255),
    script_details TEXT
);
