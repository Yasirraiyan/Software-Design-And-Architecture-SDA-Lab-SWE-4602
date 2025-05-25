ALTER TABLE quest_participation
DROP COLUMN is_up_vote;

ALTER TABLE quest_participation
ADD COLUMN rating INT CHECK (rating BETWEEN 1 AND 5);

ALTER TABLE quest_participation
ADD COLUMN rating_timestamp TIMESTAMP;